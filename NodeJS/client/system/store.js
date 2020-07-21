import Vue from 'vue'
import Vuex from 'vuex'

import SystemApi from './api'

Vue.use(Vuex)
Vue.use(SystemApi)

const _debug = false

function de(e) { if (_debug) console.log('(S) ' + e) }

const store = new Vuex.Store({
    state: {
        user: undefined,
    },
    mutations: {
        setUser(state, data) {
            state.user = data
            de('loaded user')
        },
    },
    getters: {
        user: state => state.user,
    },
    actions: {
        loginUser({commit}, {username, password, success, error}) {
            return Vue.$api(store.state.user, 'loginUser', {username, password})
                .then(r => r.data || {})
                .then(u => { 
                    commit('setUser', u)
                    success() 
                })
                .catch(e => {
                    error(e)
                })
        },
    },
})

export default store
