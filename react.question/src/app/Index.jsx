import React from "react";
import {
  Router,
  Routes,
  Route,
  Switch,
  Redirect,
  useLocation,
} from "react-router-dom";

// import { Nav, Alert } from '@/_components';
// import { Home } from '@/home';
import { UserPage } from "../main/user/user-page";
import {List} from "../main/users/List"

function App() {
  return (
    <Routes>
       <Route path="/users-test" element={<List />} />
    </Routes>
  );
}

export { App };
