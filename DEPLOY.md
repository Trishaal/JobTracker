# Deploying JobTracker to AWS Free Tier

## Overview

This setup uses a single EC2 `t2.micro` instance (Free Tier eligible) running Docker Compose
with two containers: the .NET API and an nginx server serving the React frontend.

## Prerequisites

- An AWS account with Free Tier eligibility
- SSH key pair created in AWS (for accessing the EC2 instance)

## Steps

### 1. Launch an EC2 t2.micro instance

- **AMI**: Ubuntu Server 22.04 LTS (or 24.04)
- **Instance type**: `t2.micro` (Free Tier)
- **Storage**: 8 GB gp2 (default)
- **Security group**: Allow inbound HTTP (port 80) and SSH (port 22)
- **Key pair**: Use an existing one or create a new one

### 2. Install Docker on the instance

```bash
ssh -i your-key.pem ubuntu@<instance-public-ip>

# Install Docker
sudo apt-get update
sudo apt-get install -y ca-certificates curl gnupg
sudo install -m 0755 -d /etc/apt/keyrings
curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo gpg --dearmor -o /etc/apt/keyrings/docker.gpg
echo "deb [arch=$(dpkg --print-architecture) signed-by=/etc/apt/keyrings/docker.gpg] https://download.docker.com/linux/ubuntu $(lsb_release -cs) stable" | sudo tee /etc/apt/sources.list.d/docker.list
sudo apt-get update
sudo apt-get install -y docker-ce docker-ce-cli containerd.io docker-compose-plugin

# Allow current user to run Docker
sudo usermod -aG docker $USER
# Log out and back in, or run: newgrp docker
```

### 3. Clone and deploy

```bash
git clone <your-repo-url> jobtracker
cd jobtracker

# Build and start
docker compose -f docker-compose.prod.yml up -d --build

# Verify
curl http://localhost/api/jobapplications
```

### 4. Access the app

Open `http://<instance-public-ip>` in your browser.

## Notes

- The API uses an **in-memory database** — data is lost when the API container restarts.
  To persist data, switch to PostgreSQL (see project docs) and add a DB service to the compose file.
- .NET 5.0 is end-of-life. For production, consider upgrading to .NET 8 (LTS).
- For HTTPS, add a certificate (e.g., via Let's Encrypt/Certbot) and configure nginx for TLS.
- Free Tier limits: 750 hours/month of t2.micro for the first 12 months.
