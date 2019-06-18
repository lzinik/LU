import React , { Component } from "react";

class Header extends Component {
    constructor(props) {
        super(props);

        this.state = {
            text: "Initial State",
            newState: ""
        };
    }

    updateState = (e) => {
        this.setState({
            newState: e.target.value
        });
    };

    handleOnClick = () => {
        this.setState((state) => {
            return {
                text: state.newState
            }
        });
    };

    render() {
        
        return (
            <div>
                <h1>{this.state.text}</h1>
                <input value={this.state.newState} onChange={this.updateState}/>
                <button onClick={ this.handleOnClick }>Click me! </button>
            </div>
        );
    }
}
export default Header;