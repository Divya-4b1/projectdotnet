import { useState } from "react";

function Payments(){
    const [PaymentList,setPaymentList]=useState([])
    const[cardNumber,setcardNumber]=useState("");
    const[expiryDate,setexpiryDate]=useState("");
    const[cvv,setcvv]=useState("");
    const[paymentAmount,setpaymentAmount]=useState("");
    var getPayments = ()=>{
        fetch('https://localhost:7134/api/PaymentDetails',{
            method:'GET',
            headers:{
                'Accept':'application/json',
                'Content-Type':'application/json'
            }
        }).then(
            async (data)=>{
                var myData = await data.json();
                await console.log(myData);
                await setPaymentList(myData);
            }
        ).catch((e)=>{
            console.log(e)
        })
    }
    var checkPayments = PaymentList.length>0?true:false;
return(
    <div>
        <h1 className="alert alert-success">Payments</h1>
        <button className="btn btn-success" onClick={getPayments}>Get All PaymentDetails</button>
        <hr/>
        {checkPayments? 
            <div >
                {PaymentList.map((payment)=>
                    <div key={payment.paymentID} className="alert alert-primary">
                        Card Number : {payment.cardNumber}
                        <br/>
                        Expiry Date : {payment.expiryDate}
                        <br/>
                        CVV : {payment.cvv}
                        <br/>
                        Amount : {payment.paymentAmount}
            </div>)}
            </div>
            :
            <div>No Payments available </div>
            }
    </div>
);

}
export default Payments;