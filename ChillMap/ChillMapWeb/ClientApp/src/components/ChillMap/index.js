import React, {Component} from 'react';
import './style.css';
import mapimg from './ceil_map.svg';
import goodMap from './goodMap.svg';

class ChillMap extends Component {
    constructor(props) {
        super(props)
        this.state = {
            // onClick: props.onRegionClick
            main: true
        }
        this.onClick = this.onClick.bind(this)
    }

    onClick() {
        console.log(1)
        this.setState({main: !this.state.main})
    }

    render() {
        return (
                <div className='row' style={{height: '100%'}}>
                    <div className='col-10 offset-1'>
                        {(this.state.main) ?
                        <div className='back'>
                            <div>
                                <img className='map-box' src={mapimg} useMap={'#map'}/>
                            </div>
                            <p>
                                <map name={'map'}>
                                    <area onClick={this.onClick}
                                        className='center-dist'
                                        href='#'
                                        shape='rect'
                                        coords={'400,200,500,300'}/>
                                </map>
                            </p>
                        </div>:
                            <div onClick={this.onClick}>
                                <img className='map-box' src={goodMap}  useMap={'#map'}/>
                            </div>
                            // <div>
                            //     <h1>Shit shit shit!!!</h1>
                            // </div>
                        }
                    </div>
                </div>
        );
    }
}

export default ChillMap;
