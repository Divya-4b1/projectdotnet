import logo from './logo.svg';
import { useState } from 'react';
import './App.css';
import AddProduct from './components/AddProduct';
import Products from './components/Products';
import RegisterUser from './components/RegisterUser';
import Loginuser from './components/Loginuser';
import ProductListing from './components/ProductListing';
import Cart from './components/Cart';




//function App() {
 // var scores = [90,100,56,89,73];
  //return (
   // <div className="App">
     //     <div className="container text-center">
     //   <div className="row">
     //     <div className="col">
     //       <Products/> 
     //     </div>
      //    <div className="col">
        //    <AddProduct/>
          //</div>
       // </div>
   //// </div>
    // <div>
        //  {scores.map((score)=>
        //    <li key={score}>{score}</li>
        //  )}
    //  </div>
    //  <div>
        
    //  </div>
   // </div>
   
  
  
  // <div><RegisterUser/></div>
  // <div><Loginuser/></div>

  function App() {
    var products =[
      {
         "id":101,
         "name":"Pencil",
         "quantity":10,
         "price":5
     },
     {
         "id":102,
         "name":"Pen",
         "quantity":3,
         "price":25
     },
     {
         "id":103,
         "name":"Eraser",
         "quantity":7,
         "price":3
     }
  ]
  var [cart,setCart]=useState([]);
  var addToCart=(pid)=>{
    setCart([...cart,pid])
    console.log(cart)
    
  }
  
    return (
      <div>
      <div className="container">
          <div className="row">
            <div class="col">
             <ProductListing products={products} onAddClick={addToCart}/>
            </div>
            <div class="col">
             <Cart cartItems={cart} />
            </div>
          </div>
          
        </div>
      </div>
    );
  }
  
  export default App;