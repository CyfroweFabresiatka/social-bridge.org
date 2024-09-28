import { defineConfig } from 'vite'

export default defineConfig({
    css: {
        preprocessorOptions: {
            scss: {
                // You can add global styles, variables, etc. here
                additionalData: `@import "./src/styles/_variables.scss";`
            }
        }
    },
    resolve: {
        extensions: ['.ts', '.tsx', '.js']
    },
    server: {
        port: 3000,
    },
})
