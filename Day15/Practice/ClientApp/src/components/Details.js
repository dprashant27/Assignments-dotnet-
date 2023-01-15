import {useState,useEffect} from "react";
import axios from "axios"
const Details=()=>{
    const [list, setList] = useState([]);
    useEffect(()=>{
     axios.get('https://localhost:7018/product')
       .then(response => setList(response.data));
    }, []);
     
    return (
      <div>
         {list.map(todo => 
          <div key={todo.id}>{todo.name}</div>)}
       </div>
     );

}

export default Details;