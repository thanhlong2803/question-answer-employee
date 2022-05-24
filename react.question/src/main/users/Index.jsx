import React from 'react';
import { Route, Switch } from 'react-router-dom';

import { List } from './List';

function Users({ match }) {
    debugger
    const { path } = match;    
    return (
        <Route exact path={path} component={List} />
    );
}

export { Users };