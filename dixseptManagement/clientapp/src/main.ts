import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import vuetify from './plugins/vuetify'
// fontAwesome読み込み
import '@fortawesome/fontawesome-free/css/all.css'

import {validationObserver, validationProvider } from './common/validate'
// import {localize, extend} from 'vee-validate';
// import {required} from 'vee-validate/dist/rules';import ja from 'vee-validate/dist/locale/ja.json';


// // エラーメッセージ日本語対応
// localize('ja', ja);

// // 共通で読み込むメッセージはここに記述エラーメッセージ設定単一読み込み
// // TODO: ファイル分割したほうがいい読み込めるか謎？
// // 共通で使用するバリデーション読み込み
// extend('required', required);
Vue.component('ValidationProvider', validationProvider)
Vue.component('ValidationObserver', validationObserver)

Vue.config.productionTip = true;
new Vue({
  router,
  store,
  vuetify,
  render: h => h(App)
}).$mount('#app')
