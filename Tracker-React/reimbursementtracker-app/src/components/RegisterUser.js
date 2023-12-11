import { useState } from "react";
import './RegisterUser.css';
import axios from "axios";

function RegisterUser() {
    const roles = ["HR", "Employee"];
    const [username, setUsername] = useState("");
    const [email, setemail] = useState("");
    const [password, setPassword] = useState("");
    const [repassword, setrePassword] = useState("");
    const [role, setRole] = useState("");
    var [usernameError, setUsernameError] = useState("");
    var [passwordError, setPasswordError] = useState("");
    var [emailError, setemailError] = useState("");
    var checkUSerData = () => {
        if (username == '') {
            setUsernameError("Username cannot be empty");
            return false;
        }
        return true
        if (password == '')
            setPasswordError("Password Cannot be empty");
        return false;
        return true

        if (email == '')
            setemailError("Email cannot be empty");
        return false;
        return true

        if (role == 'Select Role')
            return false;
        return true;
    }
    const signUp = (event) => {
        event.preventDefault();
        var checkData = checkUSerData();
        if (checkData == false) {
            alert('please check yor data')
            return;
        }
        axios.post("https://localhost:7134/api/User/Register", {
            username: username,
            email: email,
            role: role,
            password: password,
        })
            .then((userData) => {
                console.log(userData)
                alert('User Registered Successfully')
            })
            .catch((err) => {
                console.log(err)
            })
    }
    return (
        <form className="registerForm">
            <h1 className="heading">Registration Form</h1>
            <label className="form-control">Username</label>
            <input type="text" className="form-control" value={username}
                onChange={(e) => { setUsername(e.target.value) }} />
            <label className="alert alert-danger">{usernameError}</label>
            <label className="form-control">E-Mail</label>
            <input type="text" className="form-control" value={email}
                onChange={(e) => { setemail(e.target.value) }} />
            <label className="alert alert-danger">{emailError}</label>
            <label className="form-control">Password</label>
            <input type="password" className="form-control" value={password}
                onChange={(e) => { setPassword(e.target.value) }} />
            <label className="alert alert-danger">{passwordError}</label>
            <label className="form-control">Re-Type Password</label>
            <input type="text" className="form-control" value={repassword}
                onChange={(e) => { setrePassword(e.target.value) }} />
            <label className="form-control">Role</label>
            <select className="form-select" onChange={(e) => { setRole(e.target.value) }}>
                <option value="select">Select Role</option>
                {roles.map((r) =>
                    <option value={r} key={r}>{r}</option>
                )}
            </select>
            <br />
            <button className="btn btn-primary button" onClick={signUp}>Sign Up</button>

            <button className="btn btn-danger button">Cancel</button>
        </form>
    );

}

export default RegisterUser;