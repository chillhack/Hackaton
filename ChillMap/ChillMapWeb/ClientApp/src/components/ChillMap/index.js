import React, {Component} from 'react';
import './style.css';
import mapimg from './ceil_map.svg';

class ChillMap extends Component{
    render() {
        return(
            <div className='row' style={{height: '100%'}} >
                <div className='col-10 offset-1'>
                    <div className='back'>
                            <div>
                                <img className='map-box' src={mapimg} useMap={'#map'}/>
                            </div>
                        <p>
                            <map name={'map'}>
                                <area className='center-dist' href='#' shape='rect' coords={'400,200,500,300'} />
                            </map>
                        </p>

                    </div>
                </div>
            </div>
        );
    }
}

export default ChillMap;
