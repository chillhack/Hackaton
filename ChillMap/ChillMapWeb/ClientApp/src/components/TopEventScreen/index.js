import React, {Component} from 'react';
import SearchLine from "../SearchLine";
import events from './events';
import EventCardBox from "../EventCardBox";

class TopEventScreen extends Component{
    render() {
        return(
            <div className={'screen'}>
                <EventCardBox events={events} />
            </div>
        );
    }
}

export default TopEventScreen;
