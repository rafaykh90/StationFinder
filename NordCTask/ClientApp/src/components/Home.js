import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Station Finder</h1>
        <p>This a simple Single Page Application for finding the suitable Link stations near the device location, built with:</p>
        <ul>
          <li><a href='https://get.asp.net/'>ASP.NET Core 2.2</a> and <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> for cross-platform server-side code</li>
          <li><a href='https://facebook.github.io/react/'>React</a> for client-side code</li>
          <li><a href='http://getbootstrap.com/'>Bootstrap</a> for layout and styling</li>
        </ul>
        <p>Click on the 'Stations' button on the top right to navigate to the Station Finder page</p>
      </div>
    );
  }
}
