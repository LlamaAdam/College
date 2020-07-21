window._ = require('lodash')

import Vue from 'vue'
import { sync } from 'vuex-router-sync'
import store from './system/store'
import router from './system/router'
store.unsync = sync(store, router)

import App from './App.vue'

const control = new Vue({
    store, router,
    components: {App},
    render: h => h(App)
}).$mount('#app')

window.control = control
