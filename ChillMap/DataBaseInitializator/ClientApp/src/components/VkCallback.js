import React, {Component} from 'react';
import axios from 'axios';

export class VkCallback extends Component {
    constructor(props) {
        super(props);
        console.log('component mounted')
        this.state = {data: this.parseHash(props.location.hash)};
        this.getAllFutureEvents = this.getAllFutureEvents.bind(this)
        this.sendUserData = this.sendUserData.bind(this)
    }

    parseHash(rawHash) {
        let result = {};
        let pairs = rawHash.substring(1).split('&');
        pairs.map(p => {
            let pair = p.split('=');
            result[pair[0]] = pair[1];
        });

        return result;
    }

    getAllFutureEvents() {
        console.log(this)
        axios.get("https://api.vk.com/method/groups.search?q=.&city_id=49&type=event&user_id=" + this.state.data['user_id'] + "&access_token=" + this.state.data['access_token'] + "&v=5.95")
            .then(resp => {
                console.log(resp);
            })
            .catch(err => console.log(err));
    }

    sendUserData() {
        axios.post('./api/dataBase/sendUserInfo', {
            token: this.state.data['access_token'],
            userId: this.state.data['user_id']
        })
    }

    render() {
        return (
            <div className="Vk">
                <button onClick={this.getAllFutureEvents}>get all future events</button>
                <button onClick={this.sendUserData}>send user data</button>
                <p><a
                    href={"https://api.vk.com/method/groups.get?extended=1&fields=city,place,description,members_count,counters,start_date,finish_date,activity,contacts,links&filter=events&user_id=" + this.state.data['user_id'] + "&access_token=" + this.state.data['access_token'] + "&v=5.95"}>get
                    my events</a></p>
                <p><a
                    href={"https://api.vk.com/method/groups.search?q=.&city_id=49&type=event&user_id=" + this.state.data['user_id'] + "&access_token=" + this.state.data['access_token'] + "&v=5.95"}>get
                    all future events</a></p>
            </div>
        );
    }
}