
import { useState } from "react";

function UserProfiles(){
    const [ProfilesList,setProfilesList]=useState([])
    var getProfiles = ()=>{
        fetch('https://localhost:7134/api/UserProfile',{
            method:'GET',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json'
            }
        }).then(
            async (data)=>{
                var myData = await data.json();
                await console.log(myData);
                await setProfilesList(myData);
            }
        ).catch((e)=>{
            console.log(e)
        })
    }
    var checkProfiles = ProfilesList.length>0?true:false;
return(
    <div>
        <h1 className="alert alert-success">User Profiles</h1>
        <button className="btn btn-success" onClick={getProfiles}>Get All UserProfiles</button>
        <hr/>
        {checkProfiles? 
            <div >
                {ProfilesList.map((profile)=>
                    <div key={profile.username} className="alert alert-primary">
                        User Name : {profile.username}
                        <br/>
                        Full Name : {profile.full_Name}
                        <br/>
                        City : {profile.city}
                        <br/>
                        Contact Number : {profile.contactNumber}
                        <br/>
                        Bank Account Number : {profile.bankAccountNumber}
            </div>)}
            </div>
            :
            <div>No user profiles available yet</div>
            }
    </div>
);
}

export default UserProfiles;   	