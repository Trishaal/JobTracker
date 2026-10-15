import { defineConfig } from 'vite';
import react from '@vitejs/plugin-react';

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [react()],
  server: {
    port: 3000,
    strictPort: true,
    // In Base44 preview mode, allow the sandbox proxy host
    ...(process.env.BASE44_PREVIEW_MODE === '1' ? { allowedHosts: true } : {}),
  },
  preview: {
    port: 3000,
    strictPort: true,
  },
});
