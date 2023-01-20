import React from 'react'
import Logo from '../../addons/logo.png'
import '../../styles/loginStyle.css'
import { useState} from 'react';

import { login_user_newstate, set_canSubmit_false, set_canSubmit_true } from '../../redux/slices/loginSlices';
import { useDispatch, connect} from 'react-redux';

import { bindActionCreators } from 'redux';
import { useAppDispatch, useAppSelector } from '../../redux/store';

import axios from 'axios'

export const Login = () => {

  const [temail, setEmail] = useState("")
  const [pass, setPass] = useState("")
  const dispatch = useAppDispatch()
  const isLoggin = useAppSelector(state => state.login_act.isLoggin)
  const getCanSubmit = useAppSelector(state => state.login_act.canSubmit)

  async function sendData(){
    dispatch(set_canSubmit_false())
    const URL = "https://localhost:7072/api/UsersAuth/login" //modify the URL
    console.log(temail)
    console.log(pass)
    try{
      const res = await axios.post(URL, {email: temail, password: pass} )
      console.log(res)
      if(res.status == 200){
        localStorage.setItem("token",res.data.result.token)
      }
    }catch{
      alert("Error usuario o contraseña incorrecta, intente nuevamente")
      //localStorage.setItem("token",token)
    }
    dispatch(set_canSubmit_true())
  }

  return (
    <div className='loginCont'>
      <h2>Login</h2>
      <b><p>Email:</p></b>
      <input type="email" name='emailButton' value={temail}
      onChange={(e) => {setEmail(e.target.value)}}
      ></input>
      <b><p>Pass:</p></b>
      <input type="password" name='passButton' value={pass}
      onChange={(e) => {setPass(e.target.value)}}
      ></input>
      <br />
      <button name='submitButton' onClick={(e) => sendData()}
      id={getCanSubmit? "show_submit" : "hidden_submit"}>Submit</button>
      <p id={!getCanSubmit? "show_p" : "hidden_p"}>Waiting...</p>
      <a href='/register'>
        <p> Dont have an account? Click here</p>
      </a>
    </div>
  )
}



const mapLoginAction = (login_state: any) => ({
  user: login_state.user,
  isLogged: login_state.isLogged,
  canSubmit: login_state.canSubmit
})

//¿Para que sirve esta funcion?
function mapDispatchToProps(dispatch: any) {
  return bindActionCreators(login_user_newstate, dispatch)
}

export default connect(mapLoginAction, mapDispatchToProps)(Login)

