import React from 'react';

export default function StartScreen() {
    return (
        <div className='start-screen'>
            <div className='row' style={{height: '70px'}}>
                <div className='col-2'>
                    <div className='logo'>

                    </div>
                </div>
                <div className='col-2 offset-8'>
                    <div className='login'>

                    </div>
                </div>
            </div>
            <div className='row' style={{height: '130px'}}>
                <div className='col-4'>
                    <div className='header'>
                        <h1>ChillMap</h1>
                    </div>
                </div>
            </div>
            <div className='row'>
                <div className='col col-lg-6'>
                    <div className='description'>
                        <p>Андерграундная карта</p>
                    </div>
                </div>
            </div>
        </div>
    );
}