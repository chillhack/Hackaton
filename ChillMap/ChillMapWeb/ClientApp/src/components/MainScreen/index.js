import React, {Component} from 'react';
import NavPanel from "../NavPanel";
import './style.css';
import 'bootstrap/dist/css/bootstrap.css';
import StartScreen from "../StartScreen";
import img from './first_screen_bg.svg';
import ChillMap from "../ChillMap";
import TopEventScreen from "../TopEventScreen";

export default class MainScreen extends Component{
    constructor(props){
        super(props);

        this.state = {
            activeScreen: 0,
        }
    }

    render(){
        const screens = [<StartScreen/>, null, <TopEventScreen />, <ChillMap />, null];

        let back =
            this.state.activeScreen === 0 ? <img alt='background' src={img} className='backgroundImage'/> : '';

        return(
            <div className='main'>
                {back}
                <div className='row'>
                    <div className='col-12'>
                        <div className={'screen'}>
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
        console.log(index);
        this.setState({activeScreen: index});
    }
}
