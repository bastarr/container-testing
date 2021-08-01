import React from "react";
import logo from "./logo.svg";
import "./App.css";
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom';
import { Home } from "./Home";
import { Navbar } from "./Navbar";
import { About } from "./About";
import { Weather } from "./Weather";

function App() {
  return (
    <Router>
      <div className="app">
        <header className="app-header">
          <Navbar />
          <img src={logo} className="app-logo" alt="logo" />
          <div className="content">
            <Switch>
              <Route exact path="/">
                <Home />
              </Route>              
              <Route path="/about">
                <About />
              </Route>   
              <Route path="/weather">
                <Weather />
              </Route>                          
            </Switch>
          </div>
        </header>
      </div>
    </Router>
  );
}

export default App;
