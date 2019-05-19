import React, {Component} from 'react';
import './style.css';
// import backImg from './ceil_map.svg';
import mapimg from './ceil_map.svg';
import goodMap from './goodMap.svg';
import image1 from './maps/1.svg'
import image2 from './maps/2.svg'
import image3 from './maps/3.svg'
import image4 from './maps/4.svg'
import image5 from './maps/5.svg'
import image6 from './maps/6.svg'
import image7 from './maps/7.svg'

class ChillMap extends Component {
    constructor(props) {
        super(props)
        this.state = {
            // onClick: props.onRegionClick
            main: true,
            im: 1
        }
        this.onClick1 = this.onClick1.bind(this)
        this.onClick2 = this.onClick2.bind(this)
        this.onClick3 = this.onClick3.bind(this)
        this.onClick4 = this.onClick4.bind(this)
        this.onClick5 = this.onClick5.bind(this)
        this.onClick6 = this.onClick6.bind(this)
        this.onClick7 = this.onClick7.bind(this)
        this.onClickBack = this.onClickBack.bind(this)
    }

    onClick1() {
        console.log(1)
        this.setState({main: false, im: 1})
    }

    onClick2() {
        console.log(2)
        this.setState({main: false, im: 2})
    }

    onClick3() {
        console.log(3)
        this.setState({main: false, im: 3})
    }

    onClick4() {
        console.log(4)
        this.setState({main: false, im: 4})
    }

    onClick5() {
        console.log(5)
        this.setState({main: false, im: 5})
    }

    onClick6() {
        console.log(6)
        this.setState({main: false, im: 6})
    }

    onClick7() {
        console.log(7)
        this.setState({main: false, im: 7})
    }

    onClickBack() {
        console.log('back')
        this.setState({main: true})
    }

    selectImage() {
        switch (this.state.im) {
            case 1:
                return image1
            case 2:
                return image2
            case 3:
                return image3
            case 4:
                return image4
            case 5:
                return image5
            case 6:
                return image6
            case 7:
                return image7
        }
    }

    render() {
        return (
            <div className='row' style={{height: '100%'}}>
                <div className='col-10 offset-1'>
                    <div className='back'>
                        <div>
                            <img className='map-box' src={mapimg} useMap={'#map'} z-index="-1"/>
                            {/*<img className='map-box' src={this.selectImage()} useMap={'#map'}/>*/}
                            {/*<BackImg/>*/}
                        </div>
                        <p>
                            <map name={'map'}>
                                <area onClick={this.onClick5}
                                      className='center-dist'
                                      href='#'
                                      shape='rect'
                                      coords={'400,200,500,300'}/>

                                <area onClick={this.onClick2}
                                      className='left-dist'
                                      href='#'
                                      shape='rect'
                                      coords={'200,200,400,400'}/>
                                <area onClick={this.onClick3}
                                      className='left-dist'
                                      href='#'
                                      shape='rect'
                                      coords={'210,60,425,225'}/>
                                <area onClick={this.onClick4}
                                      className='left-dist'
                                      href='#'
                                      shape='rect'
                                      coords={'425,60,600,225'}/>
                                <area onClick={this.onClick6}
                                      className='left-dist'
                                      href='#'
                                      shape='rect'
                                      coords={'500,200,600,350'}/>
                                <area onClick={this.onClick7}
                                      className='left-dist'
                                      href='#'
                                      shape='rect'
                                      coords={'550,350,700,450'}/>
                                <area onClick={this.onClick1}
                                      className='left-dist'
                                      href='#'
                                      shape='rect'
                                      coords={'375,350,550,450'}/>
                            </map>
                        </p>
                    </div>
                </div>
                {/*<div onClick={this.onClickBack} className='col-10 offset-2'>*/}
                {/*    <img className='map-box' src={this.selectImage()} useMap={'#map'}/>*/}
                {/*</div>*/}
            </div>
        );
    }
}

export default ChillMap;
