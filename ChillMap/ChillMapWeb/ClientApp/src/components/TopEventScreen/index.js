import React, {Component} from 'react';
import SearchLine from "../SearchLine";
import events from './events';
import EventCardBox from "../EventCardBox";
import './style.css'
import axios from 'axios'

class TopEventScreen extends Component {
    constructor(props) {
        super(props)
        this.state = {data: []}
    }

    componentWillMount() {
        axios.get('http://134.209.204.139:43301/api/events')
            .then(resp => this.setState({data: resp.data}))
    }

    render() {
        return (
            <div className={'top-screen'} style={{height:"650px"}}>
                <EventCardBox events={this.state.data} style={{height:"620px"}}/>
            </div>
        );
    }
}

export default TopEventScreen;
