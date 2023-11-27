import { useState } from "react";
//import './UserLogin.css';
import axios from "axios";

function LoginUser() {
    const [username, setUsername] = useState("");
    const [password, setPassword] = useState("");
    //var [userNameError,setUsernameError]=useState("");
    const [role,setRole] = useState("");

    var checkUserData = () => {
        if (username === '') {
            //setUsernameError("User Email cannot be empty");
            return false;
        }
        if(password==''){
            return false;
        }
        if(role==''){
            return false;
        }
    }

    const userLogin = (event) => {
        event.preventDefault();
        var checkData = checkUserData();
        if(checkData==false)
        {
            alert('Please check your data');
            return;
        }

        axios.post("http://localhost:5092/api/staff/Login", {
            username: username,
            
            password: password,
            role:role,
        })
        .then((userData)=>{
            console.log(userData.data)
        })
        .catch((err)=>{
            console.log(err)
        })
    }

    return (
        <form className="loginForm">
            <label className="form-control">User Name</label>
            <input type="text" className="form-control" value={username}
                onChange={(e) => { setUsername(e.target.value) }} />
        
            <label className="form-control">Password</label>
            <input type="password" className="form-control" value={password}
                onChange={(e) => { setPassword(e.target.value) }} />
            <label className="form-control">Role</label>
            <input type="role" className="form-control" value={role}
                onChange={(e) => { setRole(e.target.value) }} />
            <br />
            <button className="btn btn-primary button" onClick={userLogin}>Login</button>
        </form>
    );
}

export default LoginUser;