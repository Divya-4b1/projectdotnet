import { useState } from "react";
//import './RegisterUser.css';
import axios from "axios";

function RegisterUser(){
    const roles =["Staff","StoreManager","Cashier"];
    const [username,setUsername] = useState("");
    const [password,setPassword] = useState("");
    const [repassword,setrePassword] = useState("");
    const [role,setRole] = useState("");
    const signUp = (event)=>{
        event.preventDefault();
        var user = {
            "data":{
                "username": username,
                "role":	role,
                "password":password
        }
    };
        //user = JSON.stringify(user)
        console.log(user);
        axios.post("http://localhost:5092/api/staff/Register",{
            username: username,
            role:	role,
            password:password
    })
        .then((userData)=>{
            console.log(userData)
        })
        .catch((err)=>{
            console.log(err)
        })
        
    }
    return(
        <form className="registerForm">
            <label className="form-control">Username</label>
            <input type="text" className="form-control" value={username}
                    onChange={(e)=>{setUsername(e.target.value)}}/>
            <label className="form-control">Password</label>
            <input type="password" className="form-control" value={password}
                    onChange={(e)=>{setPassword(e.target.value)}}/>
            <label className="form-control">Re-Type Password</label>
            <input type="text" className="form-control" value={repassword}
                    onChange={(e)=>{setrePassword(e.target.value)}}/>
            <label className="form-control">Role</label>
            <select className="form-select" onChange={(e)=>{setRole(e.target.value)}}>
                <option value="select">Select Role</option>
                {roles.map((r)=>
                    <option value={r} key={r}>{r}</option>
                )}
            </select>
            <br/>
            <button className="btn btn-primary button" onClick={signUp}>Sign Up</button>
            
            <button className="btn btn-danger button">Cancel</button>
        </form>
    );
}

export default RegisterUser;