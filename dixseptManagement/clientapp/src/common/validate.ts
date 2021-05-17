// コンポーネント読み込み
import {ValidationProvider, ValidationObserver} from 'vee-validate';
export const validationProvider = ValidationProvider;
export const validationObserver = ValidationObserver;

import {localize, extend} from 'vee-validate';
import * as DefaultRules from 'vee-validate/dist/rules';
import ja from 'vee-validate/dist/locale/ja.json';
// 共通で読み込むカスタムバリデーションがある場合はここで読み込む
import * as DefaultCustomRules from '@/common/validateCustom';

// エラーメッセージ日本語対応
localize('ja', ja);

// 共通で読み込むメッセージはここに記述エラーメッセージ設定単一読み込み
// TODO: ファイル分割したほうがいい読み込めるか謎？
// 共通で使用するバリデーション読み込み
// 一つずる読み込む場合
//extend('required', required);
// デフォルトルールを全て読み込み
for (const rule in DefaultRules) {
   extend(rule, DefaultRules[rule])
 }

  // カスタムバリデーションを全て読み込み
 for (const rule in DefaultCustomRules) {
   extend(rule, DefaultCustomRules[rule])
}

