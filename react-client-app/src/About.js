import React, { Component } from 'react';

export class About extends Component {
  static displayName = About.name;

  render () {
    return (
      <div>
        <h1>About</h1>
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus non quam eget erat fringilla hendrerit id vel mauris. Donec tempor libero in nunc vestibulum, dignissim condimentum dolor pulvinar. Sed faucibus, ligula imperdiet dictum varius, nibh augue bibendum quam, et tincidunt mi libero et neque. Pellentesque sodales finibus velit, nec condimentum.</p>
      </div>
    );
  }
}