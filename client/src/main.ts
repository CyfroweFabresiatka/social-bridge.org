import 'vuetify/styles';
import './assets/main.scss';

import { createApp } from 'vue'
import { createVuetify } from 'vuetify';
import * as components from 'vuetify/components';
import * as directives from 'vuetify/directives';

import App from './App.vue'
import { createAppRouter } from './router'

const vuetify = createVuetify({
    components,
    directives,
});

const router = createAppRouter();

const app = createApp(App)

app.use(router)
app.use(vuetify);

app.mount('#app')
