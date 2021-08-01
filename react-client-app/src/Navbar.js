import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class Navbar extends Component {
  
  render () {
    return (
      <div className="links">
          <Link to="/" className="app-link">Home</Link> |  
          <Link to="/about" className="app-link">About</Link> | 
          <Link to="/weather" className="app-link">Weather</Link>
      </div>
    );
  }
}