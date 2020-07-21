import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

export default new VueRouter({
    mode: 'history',
    base: '/',
    routes: [
        {path: '/', name: 'dashboard', component: require('../views/Dashboard.vue').default},
        {path: '/login', name: 'login', component: require('../views/Login.vue').default},
    ]
})
