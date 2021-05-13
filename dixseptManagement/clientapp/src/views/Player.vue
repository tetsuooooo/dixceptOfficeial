<template>
  <v-container fluid>
    <v-row>
      <v-col cols="10" sm="3">
        <v-btn>登録</v-btn>
      </v-col>
    </v-row>
    <v-row justify="center">
      <v-col cols="11">
        <v-data-table :headers="headers" :items="items">
          <template v-slot:item.edit="{item}">
            <v-btn @click.stop="dialog = true" icon x-small>
              <v-icon>fas fa-edit</v-icon>
              </v-btn>
          </template>
          <template v-slot:item.delete="{item}">
            <v-btn @click="deleteItem(item.delete)" icon x-small>
              <v-icon>fas fa-trash-alt</v-icon>
              </v-btn>
          </template>
        </v-data-table>
      </v-col>
    </v-row>
    <!-- 選手編集・登録ダイアログ -->
    <v-dialog v-model="dialog" class="modal_size" width="500">
      <v-card>
        <v-row justify="end">
          <v-col cols="2" sm="2" class="text-right">
            <v-btn icon small @click="dialog = false"><v-icon>fas fa-times</v-icon></v-btn>
          </v-col>
        </v-row>
        <v-card-text>
          <ValidationObserver ref="observer" v-slot="{invalid}" immediate>
            <form>
              <v-row>
                <ValidationProvider v-slot="{errors, valid}" name="氏" rules="required">
                  <v-text-field v-model="lastName" :error-messages="errors" label="氏" required :success="valid"></v-text-field>
                </ValidationProvider>
              </v-row>
              <v-row justify="center">
                <v-col cols="12" sm="2">
                  <v-btn @click="submit" :disabled="invalid" color="success">登録</v-btn>
                </v-col>
              </v-row>
            </form>
          </ValidationObserver>
        </v-card-text>
      </v-card>
    </v-dialog>
  </v-container>
</template>

<script lang="ts">
  import { Component, Vue } from 'vue-property-decorator';
  // バリデーション
  import {localize, extend, ValidationProvider, ValidationObserver} from 'vee-validate';
  import {required} from 'vee-validate/dist/rules';
  import ja from 'vee-validate/dist/locale/ja.json';

  // エラーメッセージとして別ファイルに切り出してそのファイルを読み込む形で定義してエラーメッセージの一元管理を行うようにする
  // エラーメッセージ設定
  extend('required', required);
  // カスタムメッセージ例
  extend('awsAccountId', (value) => {
  return /^[0-9]{12}$/.test(value) || '{_field_} は12桁の数値です';
  });
  // 日本語対応
  localize('ja', ja);
@Component({
        components: {
          ValidationProvider,
          ValidationObserver
        },
    })
export default class Player extends Vue{
  deleteItem(id: number){
    confirm('選択した選手報を削除してよろしいですか？');
  }

   submit () {
     // 登録できている場合はtrue
      this.$refs.observer.validate().then(result => {
        console.log('submit', result);
      });
    }

  data(){
    return{
      // モデル
      lastName: '',
      dialog: false,
      headers:[
        {
          text: '背番号',
          value: 'backNumber',
          align: "center"
        },
        {
          text: '名前',
          value: 'name',
          align: "center"
        },
        {
          text: 'ポジション',
          value: 'position',
          align: "center"
        },
        {
          text: '編集',
          value: 'edit',
          sortable: false,
          align: "center"
        },
        {
          text: '削除',
          value: 'delete',
          sortable: false,
          align: "center"
        },
      ],
      items: [
        {
          backNumber: 1,
          name: 'サンプル太郎',
          position: 'Fixo',
          edit: 1,
          delete: 1
        },
        {
          backNumber: 1,
          name: 'サンプル太郎',
          position: 'Fixo',
          edit: 2,
          delete: 2
        },
      ]
    }
  }
}
</script>

<style>
  
</style>
