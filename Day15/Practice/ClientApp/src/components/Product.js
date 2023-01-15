import {useState,useEffect} from "react";
const Product=()=>{
    const [obj, setobj] = useState([]);
    useEffect(()=>{
     fetch('https://localhost:44413/product/{id}')
       .then(response => response.json())
       .then(setobj);
    }, []);
     
    return (
      <div>
         {obj.map(todo => 
          <div key={todo.id}><a href="/product">{todo.name}</a></div>)}
       </div>
     );

}

export default Product;