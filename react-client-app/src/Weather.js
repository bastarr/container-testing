import React, { Component } from 'react';

export class Weather extends Component {
  static displayName = Weather.name;

  constructor(props) {
    super(props);
    this.state = { data: [], setData: [] };
  }

  componentDidMount() {
    this.populateWeatherData();
  }

  componentDidUpdate() {
  }

  render () {
    return (
      <div>
        <h1>Weather</h1>
        <p>{!this.state.data ? "Loading..." : this.state.data}</p>
      </div>
    );
  }

  async populateWeatherData() {
    const res = await fetch("/api");
    const data = await res.json();

    this.setState({ data: data.message });
  }
}