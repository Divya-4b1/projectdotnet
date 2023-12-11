import { useState } from "react";

function Expenses(){
    const [ExpenseList,setExpenseList]=useState([])
    const[documentPath,setdocumentPath]=useState("");
    const[expenseCategory,setexpenseCategory]=useState("");
    const[amount,setAmount]=useState("");
    const[description,setdescription]=useState("");
    var getExpenses = ()=>{
        fetch('https://localhost:7134/api/Expenses',{
            method:'GET',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json'
            }
        }).then(
            async (data)=>{
                var myData = await data.json();
                await console.log(myData);
                await setExpenseList(myData);
            }
        ).catch((e)=>{
            console.log(e)
        })
    }
    var checkExpenses = ExpenseList.length>0?true:false;
return(
    <div>
        <h1 className="alert alert-success">Expenses</h1>
        <button className="btn btn-success" onClick={getExpenses}>Get All Expenses</button>
        <hr/>
        {checkExpenses? 
            <div >
                {ExpenseList.map((expense)=>
                    <div key={expense.expenseID} className="alert alert-primary">
                        Document Path : {expense.documentPath}
                        <br/>
                        Expense Category : {expense.expenseCategory}
                        <br/>
                        Amount : {expense.amount}
                        <br/>
                        Description : {expense.description}
            </div>)}
            </div>
            :
            <div>No Expenses available </div>
            }
    </div>
);

}
export default Expenses;