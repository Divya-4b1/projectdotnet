import { useState } from "react";
function AddRequest(){
    const requestStatuses = ["Pending", "Approved","Rejected"];
    const [requestStatus,setrequestStatus] = useState([]);
    const expenseCategories = ["Food", "Travel","Internet"];
    const [expenseCategory, setexpenseCategory] = useState([]);
    var request;
    var clickAdd = (event)=>{
        event.preventDefault();
        alert('You clicked the button');
       request={
        "requestStatus":requestStatus
        }
        console.log(request);
        fetch('https://localhost:7134/api/ReimbursementRequests',{
            method:'POST',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json'
            },
            body:JSON.stringify(request)
        }).then(
            ()=>{
                alert("Request Submitted Successfully");
            }
        ).catch((e)=>{
            console.log(e)
        })
    }


    return(
        <form className="registerForm">
        <h1 className="heading">Request Page</h1>
        
        <label className="form-control">Request Status</label>
        <select className="form-select" onChange={(e) => { setrequestStatus(e.target.value) }}>
            <option value="select">Select Status</option>
            {requestStatuses.map((r) =>
                <option value={r} key={r}>{r}</option>
            )}
        </select>
        <br/>
        <label className="form-control"> Expense Category </label>
        <select className="form-select" onChange={(e) => { setexpenseCategory(e.target.value) }}>
            <option value="select">Select Category</option>
            {expenseCategories.map((r) =>
                <option value={r} key={r}>{r}</option>
            )}
        </select>
        <br />
        <button className="btn btn-primary button" onClick={clickAdd}>Add Request</button>

        <button className="btn btn-danger button">Cancel</button>
    </form>
    );
}
export default AddRequest;