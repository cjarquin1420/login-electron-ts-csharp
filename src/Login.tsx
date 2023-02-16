import React, { useState } from 'react';

interface LoginProps {
  onSubmit: (username: string, password: string) => void;
}

const Login: React.FC<LoginProps> = ({ onSubmit }) => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState('');

  const handleSubmit = (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();

    if (!username || !password) {
      setError('Please enter a username and password.');
      return;
    }

    onSubmit(username, password);
  };

  return (
    <div className="login-container">
      <form onSubmit={handleSubmit}>
        <div className="form-group">
          <label htmlFor="username">
            Username:
          </label>
          <input
            type="text"
            id="username"
            value={username}
            onChange={(event) => setUsername(event.target.value)}
          />

        </div>
        <div className="form-group">
          <label htmlFor="password" >
             Password:
          </label>
          <input
            type="password"
            id="password"
            value={password}
            onChange={(event) => setPassword(event.target.value)}
          />
        </div>
        <input type="submit" value="Login" />
      </form>
      {error && <div className="error">{error}</div>}
    </div>
  );
};

export default Login;