import { useState } from "react";
//import './Product.css';

function AddUserProfile(){
    const [Username,setUsername] = useState("");
    const [Password,setPassword] = useState("");
    const [Role,setRole] = useState("");
    const [Full_Name,setFull_Name] = useState("");
    const [City,setCity] = useState("");
    const [email,setemail] = useState("");
    const [ContactNumber,setContactNumber] = useState("");
    const [BankAccountNumber,setBankAccountNumber] = useState("");
    var userProfile;
    var clickAdd = ()=>{
        alert('You clicked the button');
       userProfile={
        "Username":Username,
        "Full_Name":Full_Name,
        "City":City,
        "ContactNumber":ContactNumber,
        "BankAccountNumber":BankAccountNumber
        }
        console.log(userProfile);
        fetch('https://localhost:7134/api/UserProfile',{
            method:'POST',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json'
            },
            body:JSON.stringify(userProfile)
        }).then(
            ()=>{
                alert("User Registration Success");
            }
        ).catch((e)=>{
            console.log(e)
        })
    }


    return(
        <div className="inputcontainer">
            <label className="form-control" for="uname">User Name</label>
            <input id="uname" type="text" className="form-control" value={Username} onChange={(e)=>{setUsername(e.target.value)}}/>
            <label className="form-control"  for="ufn"> Full Name </label>
            <input id="ufn" type="text" className="form-control" value={Full_Name} onChange={(e)=>{setFull_Name(e.target.value)}}/>
            <label className="form-control"  for="uct">City</label>
            <input id="uct" type="text" className="form-control" value={City} onChange={(e)=>{setCity(e.target.value)}}/>
            <label className="form-control"  for="ucn">Contact Number </label>
            <input id="ucn" type="text" className="form-control" value={ContactNumber} onChange={(e)=>{setContactNumber(e.target.value)}}/>
            <label className="form-control"  for="ubn">Bank Account Number </label>
            <input id="ubn" type="text" className="form-control" value={BankAccountNumber} onChange={(e)=>{setBankAccountNumber(e.target.value)}}/>

            <button onClick={clickAdd} className="btn btn-primary">Add User Profile</button>
        </div>
    );
}
export default AddUserProfile;