import React, {Component} from 'react';
import 'bootstrap/dist/css/bootstrap.css';


class SearchLine extends Component{
    render() {
        return (
            <div className='row'>
                <div className="input-group input-group-lg">
                    <div className="input-group-prepend">
                        <span className="input-group-text" id="inputGroup-sizing-lg">Search</span>
                    </div>
                    <input type="text" className="form-control" aria-label="Large"
                           aria-describedby="inputGroup-sizing-sm" />
                </div>
            </div>
        );
    }
}

export default SearchLine;