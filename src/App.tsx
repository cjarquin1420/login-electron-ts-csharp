import React, { useState } from 'react';
import Login from './Login';

const App: React.FC = () => {
  const [loggedIn, setLoggedIn] = useState(false);

  const handleSubmit = (username: string, password: string) => {
    // Perform authentication here
    setLoggedIn(true);
  };

  return (
    <div>
      {loggedIn ? (
        <div>Welcome! You are now logged in.</div>
      ) : (
        <Login onSubmit={handleSubmit} />
      )}
    </div>
  );
};

export default App;