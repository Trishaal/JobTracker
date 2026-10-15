import React from 'react';

const App: React.FC = () => {
  return (
    <div style={{ minHeight: '100vh', background: '#f9fafb', display: 'flex', alignItems: 'center', justifyContent: 'center', padding: '1rem' }}>
      <div style={{ textAlign: 'center' }}>
        <h1 style={{ fontSize: '1.875rem', fontWeight: 700, color: '#1f2937', marginBottom: '1rem' }}>
          JobTracker Frontend
        </h1>
        <p style={{ color: '#4b5563' }}>
          Hello World! The frontend is successfully connected.
        </p>
      </div>
    </div>
  );
};

export default App;
