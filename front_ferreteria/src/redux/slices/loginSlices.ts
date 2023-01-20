import { createSlice } from '@reduxjs/toolkit'

interface User{
    email: string,
    token: string,
    isAdmin: boolean
}

const default_user = {
    email: "",
    token: "",
    isAdmin: false
}

const default_state = {
    user: default_user,
    isLoggin: false,
    canSubmit: true
}

export const loginSlice = createSlice({
    name: "login_act",
    initialState: default_state,
    reducers: {
        login_user_newstate: (state, action) => {
            state.user = action.payload
            state.isLoggin = true
            state.canSubmit = state.canSubmit
        },
        
        logout_user_state: (state) => {
            state.user = default_user
            state.isLoggin = false
            state.canSubmit = state.canSubmit
        },

        set_canSubmit_true: (state) => {
            state.user = state.user
            state.isLoggin = state.isLoggin
            state.canSubmit = true
        },

         set_canSubmit_false: (state) => {
            state.user = state.user
            state.isLoggin = state.isLoggin
            state.canSubmit = false
        }
        
    },

})

export default loginSlice.reducer
export const { login_user_newstate, logout_user_state,
    set_canSubmit_false, set_canSubmit_true } = loginSlice.actions 

export const newStateUser = (user:any) => (dispatch:any) => {
    login_user_newstate(user)
}
