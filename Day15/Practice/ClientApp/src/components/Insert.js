import { useState } from "react";
import {Link} from "react-router-dom"
import axios from "axios";


const Insert=(props)=>{
    let[ob,setob]=useState({Id:NaN,Name:"",Quantity:NaN,Price:NaN,Image:""})

    const handleChange=(event)=>{
       const {name,value}=event.target;
        setob({...ob,[name]:value});
    }

    const addData=()=>{
        axios.post('/product/insert',ob);
        
    }

    return(
        <div>
            <form method="post" >
                
                Product Id:<input type="number" name="id" id="id" onChange={handleChange}/><br/>
                Product Name:<input type="text" name="name" id="name" onChange={handleChange}/><br/>
                Quantity:<input type="number" name="quantity" id="quantity" onChange={handleChange}/><br/>
                Price:<input type="number" name="price" id="price" onChange={handleChange}/><br/>
                Image:<input type="text" name="image" id="image" onChange={handleChange}/><br/>
                
                <input type="button" onClick={addData} value="Login"/>
                
            </form>
        </div>
    )
}
export default Insert;