const path = require('path')
const { VueLoaderPlugin } = require('vue-loader')
const MiniCssExtractPlugin = require('mini-css-extract-plugin')

module.exports = {
    entry: {
        app: [
            './index.js',
            './sass/app.scss'
        ]
    },
    mode: process.env.NODE_ENV || 'none',
    output: {
        path: path.resolve(__dirname, '../public/dist'),
        filename: '[name].js'
    },
    resolve: {
        extensions: ['.js'],
        alias: {
            'vue$': 'vue/dist/vue.esm.js'
        },
    },
    module: {
        rules: [
            {
                test: /\.scss$/i,
                use: [
                    { loader:  MiniCssExtractPlugin.loader },
                    { loader: 'css-loader', options: { modules: true } },
                    { loader: 'sass-loader' }
                ]
            }, {
                test: /\.vue$/,
                use: 'vue-loader'
            }
        ]
    },
    plugins: [
        new VueLoaderPlugin(),
        new MiniCssExtractPlugin({
            filename: '[name].css'
        }),
    ]
}