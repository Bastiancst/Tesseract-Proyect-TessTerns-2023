import axios from 'axios'
import React from 'react'
import { useState } from 'react'
import Logo from '../../addons/logo.png'
import { set_canSubmit_true, set_canSubmit_false } from '../../redux/slices/loginSlices'
import { useAppSelector, useAppDispatch } from '../../redux/store'

import '../../styles/registerStyle.css'

export const Register = () => {
  const [email, setEmail] = useState("")
  const [pass, setPass] = useState("")
  const getCanSubmit = useAppSelector(state => state.login_act.canSubmit)
  const dispatch = useAppDispatch()

  async function onRegister() {
    dispatch(set_canSubmit_false())
    const URL = "https://localhost:7072/api/UsersAuth/register"
    try{
      const res = await axios.post(URL,{email: email, password: pass})
    }catch{
      alert("Error de conexion al servidor")
    }
    dispatch(set_canSubmit_true())
    window.location.href = "/"
  }

  return (
    <div className='registerCont'>
      <h2>Register</h2>
      <b><p>Email:</p></b>
      <input type="email" name='emailButton'></input>
      <b><p>Password:</p></b>
      <input type="password" name='passButton'></input><br />
      <b><p>Confirm Password:</p></b>
      <input type="password" name='confirm_password'></input><br />
      <button name='submitButton' onClick={(e) => onRegister()}
        id={getCanSubmit ? "show_submit" : "hidden_submit"}>Submit</button>
      <p id={!getCanSubmit ? "show_p" : "hidden_p"}>Waiting...</p>

      <a href='/login'>
        <p>I already have an account</p>
      </a>
    </div>
  )
}
