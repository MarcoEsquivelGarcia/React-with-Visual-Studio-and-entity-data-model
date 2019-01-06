"use strict";

var path = require("path");
var WebpackNotifierPlugin = require("webpack-notifier");
var BrowserSyncPlugin = require("browser-sync-webpack-plugin");

// https://sochix.ru/how-to-integrate-webpack-into-visual-studio-2015/
module.exports = {
    entry: "./src/index.js",
    output: {
        path: path.resolve(__dirname, "./src"),
        filename: "Reactbundle.js"
    },
    //devServer: {
    //    contentBase: ".",
    //    host: "localhost",
    //    port: 9000
    //},
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader"
                }
            },
            {
                test: /\.(css|less)$/,
                use: ["style-loader", "css-loader"]
            }
        ]
    },
    // Enable Source Map
    // https://webpack.js.org/configuration/devtool/
    devtool: "inline-source-map",
    plugins: [new WebpackNotifierPlugin(), new BrowserSyncPlugin()]
};
