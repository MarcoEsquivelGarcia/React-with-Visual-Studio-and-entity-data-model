import React, { Component } from 'react';
import CreateAccount from '../CreateAccount/CreateAccount.js';
class Home extends Component{
   render(){
     return(
        <div>
           <h1>Home</h1>
             <CreateAccount />
        </div>
     );
   }
}
export default Home;
