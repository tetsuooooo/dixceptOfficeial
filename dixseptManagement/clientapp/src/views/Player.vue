<template>
    <v-container fluid>
        <v-row>
            <v-col cols="10" sm="3">
                <v-btn>新規登録</v-btn>
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
                            <v-row justify="center">
                                <v-col cols="7">
                                    <ValidationProvider #default="{errors, valid}" name="写真" rules="required|image" ref="imageValidate">
                                        <v-file-input accept="image/*" :error-messages="errors" label="写真" required :succcess="valid" clearable prepend-icon="far fa-image" @change="imagePiked"></v-file-input>
                                    </ValidationProvider>
                                </v-col>
                                <v-col cols="11">
                                    <v-img v-if="uploadImageUrl" :src="uploadImageUrl" height="200" contain></v-img>
                                </v-col>
                            </v-row>
                            <v-row justify="center">
                                <ValidationProvider #default="{errors, valid}" name="背番号" rules="required|numeric|max:2">
                                    <v-text-field v-model="uniformNumber.number" :error-messages="errors" label="背番号" required :success="valid" clearable counter="2" prepend-icon="fas fa-sort-numeric-up"></v-text-field>
                                </ValidationProvider>
                            </v-row>
                            <v-row justify="center">
                                <ValidationProvider #default="{errors, valid}" name="氏" rules="required">
                                    <v-text-field v-model="lastName" :error-messages="errors" label="氏" required :success="valid" clearable prepend-icon="fas fa-signature"></v-text-field>
                                </ValidationProvider>
                            </v-row>
                            <v-row justify="center">
                                <ValidationProvider #default="{errors, valid}" name="名" rules="required">
                                    <v-text-field v-model="firstName" :error-messages="errors" label="名" required :success="valid" clearable prepend-icon="fas fa-signature"></v-text-field>
                                </ValidationProvider>
                            </v-row>
                            <v-row justify="center">
                                <ValidationProvider #default="{errors, valid}" name="氏(ローマ字)" rules="required|nameEn">
                                    <v-text-field v-model="lastNameEn" :error-messages="errors" label="氏(ローマ字)" required :succcess="valid" clearable prepend-icon="fas fa-signature"></v-text-field>
                                </ValidationProvider>
                            </v-row>
                            <v-row justify="center">
                                <ValidationProvider #default="{errors, valid}" name="名(ローマ字)" rules="required|nameEn">
                                    <v-text-field v-model.lazy="firstNameEn" :error-messages="errors" label="名(ローマ字)" required :succcess="valid" clearable prepend-icon="fas fa-signature"></v-text-field>
                                </ValidationProvider>
                            </v-row>
                            <v-row justify="center">
                                <ValidationProvider #default="{errors, valid}" name="出身地" rules="required">
                                    <v-text-field v-model="birthPlace" :error-messages="errors" label="出身地" required :succcess="valid" clearable prepend-icon="fas fa-location-arrow"></v-text-field>
                                </ValidationProvider>
                            </v-row>
                            <v-row justify="center">

                                <v-menu ref="menu" v-model="menu" :close-on-content-click="false" :return-value.sync="birthDay" transition="scale-transition" offset-y min-width="auto">
                                    <template v-slot:activator="{ on, attrs }">
                                        <ValidationProvider #default="{errors, valid}" name="生年月日" rules="required">
                                            <v-text-field readonly v-bind="attrs" v-on="on" v-model="birthDay" :error-messages="errors" label="生年月日" required :succcess="valid" clearable prepend-icon="fas fa-birthday-cake"></v-text-field>
                                        </ValidationProvider>
                                    </template>
                                    <v-date-picker v-model="birthDay" color="green" elevation="15" year-icon="fas fa-birthday-cake">
                                        <v-spacer></v-spacer>
                                        <v-btn text color="primary" @click="menu = false">Cancel</v-btn>
                                        <v-btn text color="primary" @click="$refs.menu.save(birthDay)">OK</v-btn>
                                    </v-date-picker>
                                </v-menu>
                            </v-row>
                            <v-row justify="center">
                                <v-col cols="7">
                                    <v-select label="ポジション" v-model.number="position" :items="positions" item-text="label" item-value="value" prepend-icon="fas fa-user-shield"></v-select>
                                </v-col>
                            </v-row>
                            <v-row justify="center">
                                <v-col cols="7">
                                    <v-slider color="green" v-model.number="height" :thumb-size="24" label="身長" thumb-label="always" prepend-icon="fas fa-male" :max="200" :min="130"></v-slider>
                                </v-col>
                            </v-row>
                            <v-row justify="center">
                                <v-col cols="7">
                                    <v-slider color="green" v-model.number="weight" :thumb-size="24" label="体重" thumb-label="always" prepend-icon="fas fa-male" :max="100" :min="30"></v-slider>
                                </v-col>
                            </v-row>
                            <v-row justify="center">
                                <v-col cols="11">
                                    <ValidationProvider #default="{errors, valid}" name="コメント" rules="required">
                                        <v-textarea auto-grow outlined v-model="comment" :error-messages="errors" label="コメント" required :succcess="valid" clearable prepend-icon="far fa-comment" clear-icon="mdi-close-circle"></v-textarea>
                                    </ValidationProvider>
                                </v-col>
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
    // カスタムバリデーション読み込み(画面単位で読み込バリデーションがある場合)

    @Component({
    })
    export default class Player extends Vue {
        deleteItem(id: number) {
            confirm('選択した選手報を削除してよろしいですか？');
        }

        submit() {
            // 登録できている場合はtrue
            this.$refs.observer.validate().then(result => {
                console.log('submit', result);
            });
        }

        data() {
            return {
                menu: false,
                // セレクトボックスのなか
                // apiで取得するようにする
                positions: [
                    {
                        label: 'Goleiro',
                        value: 1
                    },
                    {
                        label: 'Fixo',
                        value: 2
                    },
                    {
                        label: 'Ala',
                        value: 3
                    },
                    {
                        label: 'Pivo',
                        value: 4
                    },
                ],
                // モデル
                // オブジェクトとして持っておくその方がjsonにしてapiでデータを渡しやすい
                uniformNumber: 1,
                lastName: '',
                firstName: '',
                lastNameEn: '',
                firstNameEn: '',
                weight: 60,
                height: 170,
                position: 1,
                birthPlace: '',
                birthDay: '1995-10-30',
                comment: 'コメント',
                image: '',
                dialog: false,
                // 送信用画像url
                uploadImageUrl: '',
                headers: [
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
        // 画像プレビュー処理
        imagePiked(file) {
            // バリデーションエラー
            if (!this.$refs.imageValidate.validate(file)) {
                return;
            }
            if (file !== undefined && file !== null) {
                // 拡張子がない場合はrerurn
                if (file.name.lastIndexOf('.') <= 0) {
                    return
                }

                const fr = new FileReader()
                fr.readAsDataURL(file)
                fr.addEventListener('load', () => {
                    this.$data.uploadImageUrl = fr.result
                })
            } else {
                this.$data.uploadImageUrl = ''
            }
        }

    }
</script>

<style>
</style>
