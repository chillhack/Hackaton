import React, { Component } from 'react';
import axios from 'axios';

export class VkApi extends Component {
    constructor (props) {
        super(props);
        this.state = { url: 'https://oauth.vk.com/authorize?client_id=6988109&display=popup&redirect_uri=https://localhost:5001/callback&scope=friends,groups,offline&response_type=token&v=5.95' };
    }
    // onClick() {
    //     axios
    // }

    render () {
        return (
            <div className="VkApi">
                <a href={this.state.url}>Login through VK</a>
            </div>
        );
    }
}