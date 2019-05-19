import React, {Component} from 'react';
import NavPanel from "../NavPanel";
import './style.css';
import 'bootstrap/dist/css/bootstrap.css';
import StartScreen from "../StartScreen";

export default class MapScreen extends Component{
    constructor(props){
        super(props);

        this.state = {
            activeScreen: 0,
        }
    }

    render(){
        const screens = [<StartScreen/>];
        return(
            <div className='main'>
                <div className='row'>
                    <div className='col-12'>
                        <div className='screen'>
                            {screens[this.state.activeScreen]}
                        </div>
                    </div>
                </div>
                <div className='row align-items-end'>
                    <div className='col-6 offset-3'>
                            <NavPanel
                                clickHandler={ (i) => this.onClick(i) }
                            />
                    </div>
                </div>
            </div>
        );
    }


    onClick = (index) => {
        this.setState({activeScreen: index});
    }
}
