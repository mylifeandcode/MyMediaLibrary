'use client';

export default function Login() {
  const submitCredentials = () => {
    console.log("Logging in...");
  };
  
  return (
    <div>
      Login!
      <form onSubmit={submitCredentials}>
        <label>Username</label><input id="username" type="text"></input><br />
        <label>Password</label><input id="password" type="password"></input><br />
        <button type="submit">Log In</button>
      </form>
    </div>
  );
}
