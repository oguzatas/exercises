import React, {Component } from "react";

class Message extends Component {

    constructor () {
        super()
        this.state = {
            message: 'Welcome visitor'
        }



    }
    changeMessage () {
        this.setState({
            message: 'Yo Brave Ma Man'
    })
}


    render () {
        return (
            <div>
            <h1>{this.state.message}</h1>
            <button onClick={() => this.changeMessage()} >Yolo SWAG</button>
            </div>
            
        )
}


export default Message;