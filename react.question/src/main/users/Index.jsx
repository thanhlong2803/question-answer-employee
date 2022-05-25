import React from "react";
import { Route, Routes, useLocation } from "react-router-dom";

import { List } from "./List";
import { AddOrUpdate } from "./AddOrUpdate";

function Users({ match }) {
  const { pathname } = useLocation();
  return (
    <Routes>
      <Route exact path="" element={<List />} />
      <Route path={`${pathname}/add`} element={<AddOrUpdate />} />
      <Route path={`${pathname}/edit/:id`} element={<AddOrUpdate />} />
    </Routes>
  );
}
export { Users };
