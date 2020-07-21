import axios from 'axios'

let base = '/api'

let methods = {
    loginUser: (options, {username, password}) => axios.post(base + '/login', {username, password}, options),
}

function callapi(user, method, payload) {
    let api_token = _.isObject(user) ? user.api_token : ''
    let api_options = {'headers': {'Authorization': "Bearer " + api_token}}
    if (!methods[method]) return new Promise(() => {throw new Error('No method ' + method)})
    return methods[method](api_options, payload)
}

export default {
    api: callapi,
    install(Vue, options) {
        Vue.$api = callapi
    }
}
