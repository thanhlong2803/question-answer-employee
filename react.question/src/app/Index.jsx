import React from "react";
import {  Routes,  Route,  Switch,  Redirect,  useLocation,} from "react-router-dom";
// import { Nav, Alert } from '@/_components';
// import { Home } from '@/home';

import {Users} from "../main/users/Index"

function App() {
  return (
    <Routes>      
       <Route path="/users" component={Users} />
    </Routes>     
  );
}

export { App };
