import React, { Component } from 'react';
import { Route } from 'react-router';
import { VkApi } from './components/Vk'
import {VkCallback} from "./components/VkCallback";

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <div>
        <Route exact path='/' component={VkApi} />
        <Route path='/callback' component={VkCallback} />
      </div>
    );
  }
}
