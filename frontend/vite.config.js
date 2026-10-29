import react from '@vitejs/plugin-react'
import {defineConfig} from 'vite'

// https://vite.dev/config/
export default defineConfig({
    plugins: [react()],
    envPrefix: "PUBLIC_",
    server:
        {
            proxy:
                {
                    '/api/test':
                        {
                            target: 'http://13.50.242.217:5201',
                            changeOrigin: true,
                        }
                }
        }
})
