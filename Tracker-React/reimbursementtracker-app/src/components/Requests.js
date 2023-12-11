import { useState } from "react";

function Requests(){
    const [RequestList,setRequestList]=useState([])
    const[requestDate,setrequestDate]=useState("");
    var getRequests = ()=>{
        fetch('https://localhost:7134/api/ReimbursementRequests',{
            method:'GET',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json'
            }
        }).then(
            async (data)=>{
                var myData = await data.json();
                await console.log(myData);
                await setRequestList(myData);
            }
        ).catch((e)=>{
            console.log(e)
        })
    }
    var checkRequests = RequestList.length>0?true:false;
return(
    <div>
        <h1 className="alert alert-success">Requests</h1>
        <button className="btn btn-success" onClick={getRequests}>Get All Requests</button>
        <hr/>
        {checkRequests? 
            <div >
                {RequestList.map((request)=>
                    <div key={request.requestID} className="alert alert-primary">
                        Request Status : {request.requestStatus}
                        <br/>
                        Expense Category : {request.expenseCategory}
                        <br/>
                        Request Date : {request.requestDate}
                        <br/>
            </div>)}
            </div>
            :
            <div>No Requests available yet</div>
            }
    </div>
);

}
export default Requests;