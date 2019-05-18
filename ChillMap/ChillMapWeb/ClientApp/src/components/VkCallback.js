import React, { Component } from 'react';

export class VkCallback extends Component {
    constructor (props) {
        super(props);
        this.state = {data: this.parseHash(props.location.hash)};
    }

    parseHash(rawHash) {
        let result = {};
        let pairs = rawHash.substring(1).split('&');
        pairs.map(p =>
        {
            let pair = p.split('=');
            result[pair[0]] = pair[1];
        });
        return result;
    }
//<a href="https://api.vk.com/method/users.get?user_id=210700286&access_token=491cae831abadbaa503f753f51176cafdbb71f9de23628706fd6dabdf7190b305924964f275fa13d336df&v=5.95">get users</a>
    componentDidMount() {
        //const values = queryString.parse(this.props.location.search)
        //console.log(values.filter) // "top"
        //console.log(values.origin) // "im"
    }

    render () {
        return (
            <div className="Vk">
                <a href={"https://api.vk.com/method/groups.get?extended=1&fields=city,place,description,members_count,counters,start_date,finish_date,activity,contacts,links&filter=events&user_id=" + this.state.data['user_id'] + "&access_token=" + this.state.data['access_token'] + "&v=5.95"}>get my events</a>
                <p>1</p>
                <a href={"https://api.vk.com/method/groups.search?q=.&city_id=49&type=event&user_id=" + this.state.data['user_id'] + "&access_token=" + this.state.data['access_token'] + "&v=5.95"}>get all future events</a>
            </div>
        );
    }
}