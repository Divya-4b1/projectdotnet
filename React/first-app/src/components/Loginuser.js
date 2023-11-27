import React, { useState } from "react";
import axios from "axios";

function Loginuser() {
    const roles =["User","Admin"];
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");
    const [role,setRole] = useState("");

    const handleLogin = (event) => {
        event.preventDefault();

        const user = {
            username: username,
            password: password,
            role:role,
        };

        axios
            .post("http://localhost:5054/api/Customer/Login", user)
            .then((response) => {
                console.log("Login successful:", response.data);
                // Handle successful login, e.g., redirect to a new page
            })
            .catch((error) => {
                console.error("Login failed:", error);
                // Handle login failure, e.g., show an error message to the user
            });
    };

    return (
        <form className="loginForm">
            <label className="form-control">Username</label>
            <input
                type="text"
                className="form-control"
                value={username}
                onChange={(e) => {
                    setUsername(e.target.value);
                }}
            />
            <label className="form-control">Password</label>
            <input
                type="password"
                className="form-control"
                value={password}
                onChange={(e) => {
                    setPassword(e.target.value);
                }}
            />
            <label className="form-control">Role</label>
            <input
                type="role"
                className="form-control"
                value={role}
                onChange={(e) => {
                    setRole(e.target.value);
                    <option value="select">Select Role</option>
                }}
            />
            <br />
            <button className="btn btn-primary button" onClick={handleLogin}>
                Login
            </button>
        </form>
    );
}

export default Loginuser;