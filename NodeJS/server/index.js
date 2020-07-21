'use strict'

const express = require('express')
const app = express()
const port = 3000

const contentRoot = '../public'

app.use(express.json())
app.use(express.static(contentRoot))

let assert = (res, bool, status, message) => {
    if (bool) return false
    res.status(status)
    res.write(message)
    res.end()
    return true
}

app.post('/api/login', function (req, res) {
    if (assert(res, req.is('json') === 'json', 400, 'Error: Invalid Content-Type')) return
    
    if (assert(res, req.body.username === 'test', 401, 'Invalid Username')) return
    if (assert(res, req.body.password === 'test', 401, 'Invalid Password')) return

    res.json({
        id: 1,
        name: 'Test User',
        status: 'ok',
        api_token: '12345'
    })
    res.end()
})

app.get(/.*/, function (req, res) {
    res.sendFile('index.html', { root: contentRoot })
})

app.listen(port, () => console.log(`App listening at http://localhost:${port}`))
