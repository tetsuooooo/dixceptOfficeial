// カスタムで作成したバリデーションルールを定義する
// 確認メールアドレスチェック
const email_conf = {
  // ルールを書くときに使う引数。
  params: ['email'],

  // バリデーションロジック
  validate(value, { email }) {
    return ( value && value != email ) ? false : true // or false true: バリデーションエラーなし, false: バリデーションエラーあり
  },

  // バリデーションエラーメッセージ
  message(field){
    return `※${field}が一致していません。`
  },
}

// パスワードの入力値チェック（ 0-9 a-z A-Z ! " # $ % & ' ( ) * , . / : ; < = > ? @ [ ] ^ _ ` { | } ~ ）
const password = {
  // ルールを書くときに使う引数。
  params: [],

  // バリデーションロジック
  validate(value) {
    var re = /^[0-9a-zA-Z\-!"#$%&'()*,./:;<=>?@[\]^_`{|}~]*$/
    return re.test(String(value)) // true: バリデーションエラーなし, false: バリデーションエラーあり
  },

  // バリデーションエラーメッセージ
  message(){
    return `※使用できない文字が使われています。`
  },
}

const nameEn = {
  // ルールを書くときに使う引数。
  params: [],

  // バリデーションロジック
  validate(value) {
    var re = /^[A-Z]{1}[a-z]+$/
    return re.test(String(value)) // true: バリデーションエラーなし, false: バリデーションエラーあり
  },

  // バリデーションエラーメッセージ
  message(){
    return `最初の1文字は大文字、それ以外は小文字で入力してください。`
  },
}

// 定義
export {
  nameEn,
  password
}